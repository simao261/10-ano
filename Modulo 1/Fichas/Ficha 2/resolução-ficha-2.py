# Ficha de Trabalho 2

# Exercício 1
nome = input("Introduza o seu nome: ")
print("Bem-vindo(a)", nome)

# Exercício 2
a = int(input("Introduza o primeiro número: "))
b = int(input("Introduza o segundo número: "))
c = int(input("Introduza o terceiro número: "))
resultado = a + b + c
print(a, "+", b, "+", c, "=", resultado)

# Exercício 3
numero = int(input("Introduza um número: "))
quadrado = numero * numero;
cubo = numero * numero * numero;
print("O quadrado de", numero, "é", quadrado)
print("O cubo de", numero, "é", cubo)

# Exercício 4
x = int(input("Introduza o 1º número: "))
y = int(input("Introduza o 2º número: "))
media = (x + y) / 2;
print("Média =", media)

# Exercício 5
celsius = float(input("Introduza uma temperatura em ºC: "))
fahrenheit = celsius * 1.8000 + 32
print(celsius, "º C = ", fahrenheit, "º F")

# Exercício 6
nome = input("Nome: ")
apelido = input("Apelido: ")
nome_completo = nome + " " + apelido
print("Nome completo: ", nome_completo)

# Exercício 7
numero = int(input("Introduza um número: "))
print("Número anterior:", numero - 1)
print("Número seguinte:", numero + 1)

# Exercício 8
convidados = int(input("Introduza o número de convidados: "))
preco_Kg = float(input("Introduza o preço por quilograma: "))
preco_final = ((convidados * 0.15) + 0.5) * 14.99
print("\nPreço final a pagar:", preco_final, "€")