$(document).ready(function () {
    // create DatePicker from input HTML element
    $("#datepicker").kendoDatePicker({        
       
        depth: "year",     
        format: "yyyy",     
        dateInput: true
    });



});

function RegistrarLibro() {

    var Form = $("#formRegistroLibro");
    Form.validate();
    if (Form.valid()) {
        let titulo = document.getElementById('Titulo').value.trim();
        let datepicker = document.getElementById('datepicker').value.trim();
        let paginas = document.getElementById('Paginas').value.trim();
        let genero = document.getElementById('Genero').value.trim();
        let autorId = document.getElementById('AutorId').value.trim();

        MostrarModal().then((result) => {
            if (result) {

                RegistrarDatosLibro(titulo, datepicker, paginas, genero, autorId);
            }
        })

    }


    

}

function RegistrarDatosLibro(titulo, datepicker, paginas, genero, autorId) {
    let parametros = { Titulo: titulo, Anio: datepicker, Paginas: paginas, Genero: genero, AutorId: autorId };


    let url = '../Libros/RegistrarLibro';
    fetch(url, {
        method: 'POST',
        headers: {
            "Content-Type": "application/json",
        },
        body: JSON.stringify(parametros)
    })
        .then(res => res.json())
        .then(res => {

            if (res.error) {
                swal("Error", res.msj, "warning");
            }
            else {
                swal("Confirmacion", res.msj, "success").then(() => {
                    window.location.href = "../Libros";
                });
            }

        });
}