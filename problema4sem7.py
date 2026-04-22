print("-------------------------------")
print("Ejercio15: PAR O IMPAR")
print("-------------------------------")

NUM = int(input("Ingrese número:"))

par_Impar = {
    1: "Impar",
    3: "Impar",
    5: "Impar",
    7: "Impar",
    9: "Impar",
    2: "par",
    4: "par",
    6: "par",
    8: "par",
    10: "par",
}
print("\nSALIDA:")
print("-------------------------------")
print(par_Impar.get(NUM,"Numero fuera de Rango"))