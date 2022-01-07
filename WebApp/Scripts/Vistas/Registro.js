$(document).ready(function () {
    // create DatePicker from input HTML element
    $("#datepicker").kendoDatePicker();
    //$("#datepicker").data("kendoDatePicker").readonly();

    
});

function abrirModal() {
    var Form = $("#formRegistroAutor");
    Form.validate();
    if (Form.valid()) {
        let nombre = document.getElementById('NombreCompleto').value.trim();
        let datepicker = document.getElementById('datepicker').value.trim();
        let Ciudad = document.getElementById('Ciudad').value.trim();
        let CorreoElectronico = document.getElementById('CorreoElectronico').value.trim();

        MostrarModal().then((result) => {
            if (result) {

                RegistrarDatosAutor(nombre, datepicker, Ciudad, CorreoElectronico);
            }
        })
    }


}

function RegistrarDatosAutor(nombre, datepicker, ciudad, correoElectronico) {
    let parametros = { AutorNombre: nombre, FechaNacimiento: new Date(datepicker), Ciudad: ciudad, CorreoElectronico: correoElectronico };

    
   
    let url = '../Autores/RegistrarAutor';
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
                    window.location.href = "../Autores";
                });
            }      
            
        });
}