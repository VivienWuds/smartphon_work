#include <iostream>
#include <vector>
#include <string>

struct Smartphone
{
    std::string manufacturer;
    int memory;
    double price;
};

// Функция для ввода данных о смартфоне
void inputSmartphone(Smartphone* phone)
{
    std::cout << "Введите производителя: ";
    std::cin >> phone->manufacturer;
    std::cout << "Введите объем встроенной памяти (ГБ): ";
    std::cin >> phone->memory;
    std::cout << "Введите цену: ";
    std::cin >> phone->price;
}

// Функция для вывода данных о смартфоне
void printSmartphone(const Smartphone& phone)
{
    std::cout << "Производитель: " << phone.manufacturer << "\n";
    std::cout << "Объем встроенной памяти: " << phone.memory << " ГБ\n";
    std::cout << "Цена: " << phone.price << " руб.\n";
}

// Функция для создания динамических экземпляров структуры
void createSmartphones(std::vector<Smartphone>& smartphones)
{
    for (int i = 0; i < 2; ++i)
    {
        Smartphone phone;
        inputSmartphone(&phone);
        smartphones.push_back(phone);
    }
}

// Функция main с псевдоменю
int main()
{
    std::vector<Smartphone> smartphones;
    int choice;

    do
    {
        std::cout << "Меню:\n";
        std::cout << "1. Создать смартфоны\n";
        std::cout << "2. Вывести информацию о смартфонах\n";
        std::cout << "0. Выход\n";
        std::cout << "Выберите опцию: ";
        std::cin >> choice;

        switch (choice)
        {
            case 1:
                createSmartphones(smartphones);
                break;
            case 2:
                for (const auto&phone : smartphones) {
                    printSmartphone(phone);
                }
                break;
            case 0:
    std::cout << "Выход из программы.\n";
    break;
default:
    std::cout << "Неверный выбор. Попробуйте снова.\n";
}
    } while (choice != 0) ;

return 0;
}