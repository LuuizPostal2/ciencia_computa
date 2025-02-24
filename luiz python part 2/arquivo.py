total = 0
contador = 0

while True:
    entrada = input("Digite um número (ou 'sair' para encerrar): ")
    if entrada.lower() == 'sair':
        break
    try:
        numero = float(entrada)
        total += numero
        contador += 1
    except ValueError:
        print("Entrada inválida. Por favor, digite um número válido.")

print(f"Número de tentativas: {contador}")
print(f"Total do valor armazenado: {total}")
