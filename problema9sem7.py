print("----------------------------------------")
print("Complemento4: CALCULA EL DIA SIGUIENTE.")
print("----------------------------------------")

print("Ingrese la fecha:")
a = int(input("Año:"))
m = int(input("Mes:"))
d = int(input("Dia:"))

print("\nSALIDA:")
if d > 0 and d < 30:
    print("Mañana es:", d+1, m, a)
else:
    print("Mañana es:", 1,1, a+1)

