
async function ListarLibrosPalabra() {

    let parameters = { Caso: 0, NombreAutor: "", TituloLibro: "", Anio: 0 };
    let caso = parseInt(document.getElementById('selectPalabraClave').value);
    let palabra = document.getElementById('PalabraTXT').value.trim();
    parameters.Caso = caso;

    if (!isNaN(caso) && palabra !== '') {
        switch (caso) {
            case 1:
                parameters.NombreAutor = palabra;
                break
            case 2:
                parameters.TituloLibro = palabra;
                break
            case 3:
                parameters.Anio = palabra;
                break;
        }

        let url = '../Libros/ListarPalabraClave';
        const response = await fetch(url, {
            method: 'POST',
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify(parameters)
        })
        if (response.ok) {
            let data = await response.json();
            DibujarCuerpoTabla(data.listaLibros);
        } else {
            console.error(response.status);
        }
    }


    
}

function DibujarCuerpoTabla(listalibros) {
    let cuerpoTabla = document.getElementById('cuerpoTabla');
    cuerpoTabla.innerHTML = "";
    let html = "";
    if (listalibros.length > 0) {
        for (let i = 0; i < listalibros.length; i++) {

            let item = listalibros[i];
            html += `<tr><td>${item.Id}</td><td>${item.Titulo}</td><td>${item.Anio}</td><td>${item.Genero}</td><td>${item.Paginas}</td><td>${item.NombreCompleto}</td></tr>`;
        }

        cuerpoTabla.innerHTML = html;
    }
}