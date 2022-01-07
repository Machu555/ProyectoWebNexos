

function MostrarModal(titulo = "Desea guardar los cambios?", text = "Aplicar los cambios") {
    return swal({
        title: titulo,
        text: text,
        icon: 'warning',
        buttons: true,
        dangerMode: true,

    });
}