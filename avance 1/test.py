#Script hecho por Santiago Eduardo Poblete Talamante

import pandas as pd

# Leer el archivo de texto
with open('bdd0.txt', 'r', encoding='utf-8') as file:
    lines = file.readlines()

# Crear listas para cada columna
ids = []
nombre = []
fecha = []
bloque = []
manzana = []
lote = []
# Procesar cada línea del archivo de texto
for line in lines:
    # Dividir la línea por las comas
    data = line.strip().split(', ')
    
    # Agregar cada elemento a la lista correspondiente
    ids.append(int(data[0]))
    nombre.append(data[1])
    fecha.append(data[2])
    bloque.append(data[3])
    manzana.append(int(data[4]))
    lote.append(data[5])
# Crear un DataFrame usando pandas
df = pd.DataFrame({
    'ID': ids,
    'Nombre del difunto' : nombre,
    'Fecha' : fecha,
    'Bloque' : bloque,
    'Manzana' : manzana,
    'Lote' : lote,
})


# Convertir la informacion en la columna a formato de fecha
df["Fecha"] = pd.to_datetime(df["Fecha"], format= '%d/%m/%Y').dt.date

# Guardar el DataFrame en un archivo de Excel
df.to_excel('output0.xlsx', index=False)