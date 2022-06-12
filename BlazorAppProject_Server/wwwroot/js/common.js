window.ShowToastr = (type, message) => {
    if (type == "succes") {
        toastr.success(message, "Operation successfull", { timeOut: 5000 })
    } if (type == "error") {
        toastr.error(message, "Operation fail", { timeOut: 5000 })

    }
}

window.ShowSeetAlert = (type, message) => {
    if (type == "succes") {
        sweet.success(message, "Operation successfull", { timeOut: 5000 })
    } if (type == "error") {
        sweet.error(message, "Operation fail", { timeOut: 5000 })

    }
}

function ShowDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('show');
}
function HideDeleteConfirmationModal() {
    $('#deleteConfirmationModal').modal('hide');
}