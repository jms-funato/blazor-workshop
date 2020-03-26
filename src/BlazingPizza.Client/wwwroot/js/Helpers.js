﻿function saveAsFile(filename, byteBase64) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/octet-stream;base64," + byteBase64;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}

function CustomConfirm(title, message, type) {
    return new Promise((resolve) => {
        Swal.fire({
            title: title,
            text: message,
            icon: type,
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: '実行'
        }).then((result) => {
            if (result.value) {
                resolve(true);
            } else {
                resolve(false);
            }
        });
    });
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("BlazingPizza.Client", "GetCurrentCount")
        .then(result => {
            console.log("count from js " + result);
        });
}

function dotnetInstanceInvocation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}

//function addTableScroll() {
//    $('#dtHorizontalVerticalExample').DataTable({
//        "scrollX": true,
//        "scrollY": 200,
//    });
//    $('.dataTables_length').addClass('bs-select');
//};