function saveAsFile(filename, bytesBase64) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/octet-stream;base64," + bytesBase64;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}

function MensajeConfirm(titulo, mensaje) {
    return new Promise((resolve) => {
        Swal.fire({
            title: titulo,
            text: mensaje,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Si, estoy seguro!',
            cancelButtonText: 'Cancelar'
        }).then((result) => {
            if (result.value) {
                resolve(true);
            }
            else {
                resolve(false);
            }
        });
    });
}

function MensajeError(mensaje) {
    Swal.fire({
        icon: 'error',
        title: 'Oops...',
        text: mensaje
    });
}


function MensajeOK() {
    Swal.fire({
        icon: 'success',
        title: 'La operación se realizó con éxito!',
        showConfirmButton: false,
        timer: 950
    });
}

function MensajeAtencion(mensaje) {
    Swal.fire({
        title: "Atencion!",
        text: mensaje,
        icon: "info",
        showConfirmButton: true,
    })
}

function MensajeAtencionConfirm(mensaje) {
    return new Promise((resolve) => {
        Swal.fire({
            title: "Atencion!",
            text: mensaje,
            icon: "info",
            showConfirmButton: true,
        }).then((result) => {
            resolve(true);
        });
    });
}

window.chartComponent = {
    init: function (id, type, labels, datos) {
        var ctx = document.getElementById(id).getContext('2d');

        window.chart = new Chart(ctx, {
            type: type,
            data: {
                labels: labels,
                datasets: [{
                    data: datos,
                    backgroundColor: cargaBackground(datos.length)
                }]
            },

            options: {
                responsive: true,
                maintainAspectRatio: false,
                legend: {
                    display: false
                },
            }
        });
    },
    update: function (id, type, labels, datos) {
        window.chart.data.datasets[0].data = datos;
        window.chart.data.labels = labels;
        window.chart.data.datasets[0].backgroundColor = cargaBackground(datos.length);
        window.chart.update();
    }
}
function cargaBackground(cantidadDatos) {
    var colores = ['rgba(247, 184, 178, 1)', 'rgba(172, 185, 232, 1)', 'rgba(117, 185, 219, 1)', 'rgba(155, 221, 208, 1)'];
    var backgroundColors = colores;

    var cantidadPatron = cantidadDatos / backgroundColors.length;
    var restoPatron = cantidadDatos % backgroundColors.length;

    for (var i = 1; i <= cantidadPatron; i++) {
        backgroundColors = backgroundColors.concat(colores);
    }

    for (var i = 1; i <= restoPatron; i++) {
        backgroundColors = backgroundColors.concat(colores[i - 1]);
    }

    return backgroundColors;
}


function Print() {
    $(".tableToPrint td, .tableToPrint th").each(function () { $(this).css("width", $(this).width() + "px") });
    $(".tableToPrint tr").wrap("<div class='avoidBreak'></div>");
    window.print();
}

function MensajeToast(mensaje) {
    const Toast = Swal.mixin({
        toast: true,
        position: 'top-end',
        showConfirmButton: false,
        timer: 3000,
        timerProgressBar: true,
        didOpen: (toast) => {
            toast.addEventListener('mouseenter', Swal.stopTimer)
            toast.addEventListener('mouseleave', Swal.resumeTimer)
        }
    })

    Toast.fire({
        icon: 'success',
        title: mensaje
    })
}


//https://www.youtube.com/watch?v=cOV0uV_E6bU
function initializeInactivityTimer(dotnetHelper, logoutTime, logoutMessage, notificationTime, notificationMessage) {
    if (logoutTime == 0)
        return;

    var logoutTimer;
    var notificationTimer;
    document.onmousemove = resetTimer;
    document.onkeypress = resetTimer;
    //document.addEventListener('mousemove', resetTimer);
    //document.addEventListener('keypress', resetTimer);

    resetTimer();

    function resetTimer() {
        clearTimeout(logoutTimer);
        logoutTimer = setTimeout(logout, logoutTime);

        if (notificationTime == 0)
            return;
        clearTimeout(notificationTimer);
        notificationTimer = setTimeout(notification, logoutTime - notificationTime);
    }

    function logout() {
        customMessageToast(logoutMessage, 'warning', 0);
        dotnetHelper.invokeMethodAsync('Logout');
    }

    function notification() {
        customMessageToast(notificationMessage, 'info', notificationTime);
    }

    function customMessageToast(mensaje, icon, timer) {
        const Toast = Swal.mixin({
            toast: true,
            position: 'top-end',
            showConfirmButton: false,
            timer: timer,
            timerProgressBar: true,
        })

        Toast.fire({
            icon: icon,
            title: mensaje,
        })

        document.addEventListener('mousemove', Toast.close);
        document.addEventListener('keypress', Toast.close);
    }
}




