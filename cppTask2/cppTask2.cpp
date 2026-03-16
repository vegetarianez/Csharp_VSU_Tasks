#include <iostream>
#include <string>
#include <vector>
#include <windows.h>
#include <queue>
#include <algorithm>

using namespace std;

class Dish {
    string name;
    int timeOfCook;
    int priceOfDoing;
    int priceOfSelling;
public:
    Dish(string name, int timeOfCook, int priceOfDoing, int priceOfSelling)
        : name(name), timeOfCook(timeOfCook), priceOfDoing(priceOfDoing), priceOfSelling(priceOfSelling) {

    }

    string getName() const {
        return name;
    }

    int getTimeOfCook() const {
        return timeOfCook;
    }

    int getPriceOfDoing() const {
        return priceOfDoing;
    }

    int getPriceOfSelling() const {
        return priceOfSelling;
    }

    virtual void print() const {
        cout << "Имя: " << name << endl;
        cout << "Время приготовления(минут): " << timeOfCook << endl;
        cout << "Цена приготовления: " << priceOfDoing << endl;
        cout << "Стоимость продажи: " << priceOfSelling << endl;
    }

    virtual ~Dish() = default;
};

class Drink : public Dish {
    int volume;
public:
    Drink(string name, int timeOfCook, int priceOfDoing, int priceOfSelling, int volume)
        : Dish(name, timeOfCook, priceOfDoing, priceOfSelling), volume(volume) {

    }
    void print() const override {
        Dish::print();
        cout << "Объем(мл): " << volume << endl;
    }
};

class Meal : public Dish {
    int weight;
public:
    Meal(string name, int timeOfCook, int priceOfDoing, int priceOfSelling, int weight)
        : Dish(name, timeOfCook, priceOfDoing, priceOfSelling), weight(weight) {

    }
    void print() const override {
        Dish::print();
        cout << "Вес(гр): " << weight << endl;
    }
};

class Kitchener {
    string name;
public:
    Kitchener(string name) : name(name) {}
    string getName() const {
        return name;
    }
    void setName(string setName) {
        name = setName;
    }
};

class OrderItem {
    Dish* dish;
    int timeRemaining;
    int orderTime;
public:
    OrderItem(Dish* dish, int orderTime) : dish(dish), orderTime(orderTime) {
        timeRemaining = dish->getTimeOfCook();
    }

    Dish* getDish() const {
        return dish;
    }

    int getTimeRemaining() const {
        return timeRemaining;
    }

    void decreaseTime() {
        if (timeRemaining > 0) timeRemaining -= 1;
    }

    bool isReady() const {
        return timeRemaining <= 0;
    }

    int getOrderTime() const {
        return orderTime;
    }

    void print() const {
        cout << "Заказ: " << dish->getName()
            << " (осталось: " << timeRemaining << " мин.)" << endl;
    }
};

class Cafe {
    Kitchener* kitchener;
    string name;
    vector<Dish*> dishes;
    queue<OrderItem> orderQueue;
    int money = 0;
    int totalOrders = 0;
    int completedOrders = 0;

public:
    Cafe(Kitchener* kitchener, string name, vector<Dish*> dishes)
        : kitchener(kitchener), name(name), dishes(dishes) {}

    ~Cafe() {
        for (auto dish : dishes) {
            delete dish;
        }
    }

    void earnMoney(int num) {
        money += num;
    }

    void spendMoney(int num) {
        money -= num;
    }

    void addDish(Dish* dish) {
        if (dish != nullptr) {
            dishes.push_back(dish);
            cout << "Блюдо " << dish->getName() << " добавлено в меню" << endl;
        }
    }

    void setName(string setName) {
        name = setName;
    }

    string getName() const {
        return name;
    }

    Kitchener* getKitchener() const {
        return kitchener;
    }

    int getMoney() const {
        return money;
    }

    int getQueueSize() const {
        return orderQueue.size();
    }

    void showMenu() const {
        cout << "Информация о кафе: " << name << endl;
        cout << "Шеф-повар: " << kitchener->getName() << endl;
        cout << "Денег в кассе: " << money << " руб." << endl;
        cout << "Всего заказов: " << totalOrders << ", выполнено: " << completedOrders << endl;
        cout << "Текущая очередь: " << orderQueue.size() << " заказов" << endl;
        cout << "----------------------" << endl;

        for (size_t i = 0; i < dishes.size(); ++i) {
            cout << i + 1 << ". ";
            dishes[i]->print();
            cout << "----------------------" << endl;
        }
    }

    void addOrder(Dish* dish, int currentTime) {
        if (dish != nullptr) {
            orderQueue.push(OrderItem(dish, currentTime));
            totalOrders++;
            cout << "НОВЫЙ ЗАКАЗ: " << dish->getName()
                << " (время приготовления: " << dish->getTimeOfCook() << " мин.)" << endl;
        }
    }

    void processQueue(int minutes, int currentTime) {
        if (orderQueue.empty()) return;

        OrderItem& item = orderQueue.front();
        item.decreaseTime();

        if (item.isReady()) {
            int profit = item.getDish()->getPriceOfSelling() - item.getDish()->getPriceOfDoing();
            money += profit;
            completedOrders++;

            cout << "ЗАКАЗ ГОТОВ: " << item.getDish()->getName()
                << " (прибыль: " << profit << " руб.)" << endl;

            orderQueue.pop();
        }
    }

    void showQueue() const {
        if (orderQueue.empty()) {
            cout << "Очередь заказов пуста" << endl;
            return;
        }

        cout << "ТЕКУЩАЯ ОЧЕРЕДЬ ЗАКАЗОВ:" << endl;
        queue<OrderItem> tempQueue = orderQueue;
        int position = 1;

        while (!tempQueue.empty()) {
            cout << position << ". ";
            tempQueue.front().print();
            tempQueue.pop();
            position++;
        }
    }

    Dish* getRandomDrink() {
        vector<Dish*> drinks;
        for (auto dish : dishes) {
            if (dynamic_cast<Drink*>(dish)) {
                drinks.push_back(dish);
            }
        }
        if (drinks.empty()) return dishes[rand() % dishes.size()];
        return drinks[rand() % drinks.size()];
    }

    Dish* getRandomMeal() {
        vector<Dish*> meals;
        for (auto dish : dishes) {
            if (dynamic_cast<Meal*>(dish)) {
                meals.push_back(dish);
            }
        }
        if (meals.empty()) return dishes[rand() % dishes.size()];
        return meals[rand() % meals.size()];
    }
};

class RandEvents {
    Cafe* cafe;
    vector<string> namesOfKitcheners = { "Алекс", "Борис", "Анна", "Дмитрий", "Елена" };
    vector<string> namesOfCafe = { "Шашлычный двор", "Золотая ложка", "El Gusto", "Борщ и компания", "Бабушкин погребок" };
public:
    static int generateRandNum(int start, int end) {
        return rand() % (end - start + 1) + start;
    }

    RandEvents(Cafe* cafe) : cafe(cafe) {}


    void changeKitchenerName() {
        string name = namesOfKitcheners[generateRandNum(0, namesOfKitcheners.size() - 1)];
        cafe->getKitchener()->setName(name);
        cout << "Повар сменил имя!? Теперь его зовут: " << name << endl;
    }

    void changeCafeName() {
        string name = namesOfCafe[generateRandNum(0, namesOfCafe.size() - 1)];
        cafe->setName(name);
        cout << "Кафе теперь называется: " << name << ".... И что у руководства в голове?" << endl;
    }

    Dish* orderMealByHour(int hour) {
        Dish* dish;
        if (hour >= 6 && hour < 12) {
            if (rand() % 100 < 70) {
                dish = cafe->getRandomDrink();
            }
            else {
                dish = cafe->getRandomMeal();
            }
        }
        else if (hour >= 12 && hour < 18) {
            if (rand() % 100 < 30) {
                dish = cafe->getRandomDrink();
            }
            else {
                dish = cafe->getRandomMeal();
            }
        }
        else {
            if (rand() % 100 < 50) {
                dish = cafe->getRandomDrink();
            }
            else {
                dish = cafe->getRandomMeal();
            }
        }
        return dish;
    }

    void customerWave(int currentTime) {
        int waveSize = generateRandNum(3, 7);
        cout << "НАПЛЫВ ПОСЕТИТЕЛЕЙ! Поступило " << waveSize << " заказов!" << endl;

        for (int i = 0; i < waveSize; i++) {
            int hour = (currentTime % (60 * 24)) / 60;
            Dish* dish = orderMealByHour(hour);
            cafe->addOrder(dish, currentTime);
        }
    }
};

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    srand(time(nullptr));

    vector<Dish*> dishes;
    dishes.push_back(new Drink("Кока-кола", 1, 50, 120, 350));
    dishes.push_back(new Meal("Плов", 15, 80, 200, 400));
    dishes.push_back(new Meal("Пюре", 10, 40, 110, 200));
    dishes.push_back(new Drink("Чай", 3, 10, 60, 200));
    dishes.push_back(new Meal("Борщ", 17, 70, 180, 350));
    dishes.push_back(new Drink("Кофе", 5, 20, 100, 150));

    Kitchener* alex = new Kitchener("Алекс");
    Cafe* cafe = new Cafe(alex, "Бистро", dishes);

    RandEvents randEvents(cafe);
    int gapBetweenEvents = 10;

    cafe->showMenu();

    int minutesSpended = 0;
    bool running = true;

    cout << "СИМУЛЯЦИЯ КАФЕ" << endl;
    cout << "Нажмите ESC для выхода" << endl;


    while (running) {
        Sleep(5);
        minutesSpended++;


        cout << "ВРЕМЯ: "
            << minutesSpended / (60 * 24) << " д, "
            << (minutesSpended % (60 * 24)) / 60 << " ч, "
            << minutesSpended % 60 << " мин. ===" << endl;

        cafe->processQueue(1, minutesSpended);

        if (minutesSpended % gapBetweenEvents == 0) {
            int randomNum = RandEvents::generateRandNum(1, 1000);

            if (randomNum <= 700) {
                int hour = (minutesSpended % (60 * 24)) / 60;
                Dish* dish = randEvents.orderMealByHour(hour);
                cafe->addOrder(dish, minutesSpended);
            }
            else if (randomNum <= 800) {
                randEvents.customerWave(minutesSpended);
            }
            else if (randomNum <= 900) {
                randEvents.changeKitchenerName();
            }
            else {
                randEvents.changeCafeName();
            }
        }

        if (minutesSpended % 5 == 0 && cafe->getQueueSize() > 0) {
            cafe->showQueue();
        }

        if (GetAsyncKeyState(VK_ESCAPE)) {
            running = false;
        }
    }


    cout << "ИТОГОВАЯ СТАТИСТИКА" << endl;
    cafe->showMenu();

    delete cafe;
    return 0;
}