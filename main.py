# Realizado por Carolina Rodriguez Lopez

# Se importan las librerias
import numpy as np
import time

# Una matriz cuadrada es aquella que tiene el mismo número de filas y de columnas

# Ejemplo de matriz cuadrada de orden 3x3
mc = [[1,2,3],[1,2,3],[12,3,4]]

# Se muestra la matriz en consola
mc = np.array(mc)
print('MATRIZ CUADRADA', np.shape(mc),'\n')
print(mc, "\n")

print("Transformando matriz...",'\n')
time.sleep(2.4)

# Se toma el numero de filas de la matriz, para transformarla en una matriz identidad, es decir, donde todas las entradas son iguales a cero (0), excepto los valores de la diagonal principal, que serán iguales a uno (1)
print('MATRIZ IDENTIDAD DE ORDEN', len(mc),'\n')
mi = np.identity(len(mc))
print(mi)