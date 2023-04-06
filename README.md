# CPF-validator-in-C-.NET

## How does it work?

This code is a CPF (Cadastro de Pessoas Físicas, which is the Brazilian individual taxpayer identification number) validator written in C#/.NET. The program prompts the user to input a CPF number and then checks whether it is valid or not according to the Brazilian government's validation algorithm.

The Main method is responsible for interacting with the user, prompting for input, and displaying the result of the validation. The ValidarCPF method, on the other hand, is responsible for implementing the validation algorithm.

The validation algorithm consists of several steps, including removing any dots or hyphens from the input, checking if the input has 11 digits, checking if all digits are not the same, calculating the first and second verification digits, and checking if they match the corresponding digits in the input.

If the CPF number is valid, the program will display "CPF válido!" (valid CPF). Otherwise, it will display "CPF inválido!" (invalid CPF).

Overall, this program can be useful for verifying the validity of CPF numbers in Brazil.
