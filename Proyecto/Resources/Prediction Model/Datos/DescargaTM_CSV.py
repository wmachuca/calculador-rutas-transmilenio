import requests
import subprocess
from bs4 import BeautifulSoup

# URL de la página web
url = "https://storage.googleapis.com/validaciones_tmsa/ValidacionTroncal.html"

# Nombre del archivo local donde se guardará la descarga
nombre_archivo = "ValidacionTroncal.html"

# Realizar la solicitud GET a la página
response = requests.get(url)

# Verificar si la solicitud fue exitosa (código de estado 200)
if response.status_code == 200:
    # Guardar el contenido en el archivo local
    with open(nombre_archivo, 'w', encoding='utf-8') as archivo_local:
        archivo_local.write(response.text)

    # Parsear el contenido HTML
    soup = BeautifulSoup(response.text, 'html.parser')

    # Encontrar la tabla con el atributo 'aria-describedby' igual a 'diccionario'
    tabla = soup.find('table', {'aria-describedby': 'diccionario'})

    # Verificar si se encontró la tabla
    if tabla:
        # Iterar sobre las filas de la tabla (excluyendo la primera fila que contiene encabezados)
        for fila in tabla.find_all('tr')[18:48]:
            # Obtener la etiqueta <a> de la primera celda de la fila
            etiqueta_a = fila.find('a')

            # Verificar si se encontró la etiqueta <a>
            if etiqueta_a:
                # Obtener el texto y el enlace (HREF) de la etiqueta <a>
                texto = etiqueta_a.get_text(strip=True)
                enlace = etiqueta_a.get('href')

                # Imprimir la información
                print("Texto: {}, Enlace: {}".format(texto, enlace))

                # Descargar el enlace usando wget
                subprocess.run(["wget", enlace])
    else:
        print("No se encontró la tabla con 'aria-describedby' igual a 'diccionario'.")
else:
    print("No se pudo acceder a la página. Código de estado: {}".format(response.status_code))
