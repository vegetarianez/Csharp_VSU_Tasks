

#include <iostream>
#include <vector>
#include <windows.h>
#include <string>
using namespace std;


bool* checkMatrix(int** matrix, int rows, int columns)
{
    bool* answerVector = new bool[rows];

    for (int i = 0; i < rows; ++i) {
        bool isDecreasing = true;

        for (int j = 1; j < columns; ++j) {
            if (matrix[i][j] >= matrix[i][j - 1]) {
                isDecreasing = false;
                break;
            }
        }

        answerVector[i] = isDecreasing;
    }

    return answerVector;
}







int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

   

    int rows;
    int columns;


    cout << "Введите кол-во строк: ";
    cin >> rows;
    cout << "Введите кол-во столбцов: ";
    cin >> columns;

    int** inputMatrix = new int* [rows];
    for (int i = 0; i < rows; ++i) {
        inputMatrix[i] = new int[columns];
    }



    for (int i = 0; i < rows; ++i) {
        
        cout << "Введите строку номер " << i + 1 << "(" << columns << " элементов): ";
        for (int j = 0; j < columns; ++j) {
            cin >> inputMatrix[i][j];
        }
    }

    bool* answerVector = checkMatrix(inputMatrix, rows, columns);

    for (int i = 0; i < rows; ++i) {
        cout << answerVector[i];
    }



    for (int i = 0; i < rows; ++i) {
        delete[] inputMatrix[i];
    }
    delete[] inputMatrix;
    delete[] answerVector;

    return 0;
}

