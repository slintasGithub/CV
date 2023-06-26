
function deleteCandidate(id) {
    var data = {
        id: id
    };

    $.ajax({
        type: "DELETE",
        url: "Candidate/DeleteCandidate",
        dataType: "json",
        data: data,
        success: function (result) {
            window.location = location.origin
        },
        error: function (err) {
            window.location = location.origin
        }
    })
}

function deleteDegree(id) {
    var data = {
        id: id
    };

    $.ajax({
        type: "DELETE",
        url: "Degree/DeleteDegree",
        dataType: "json",
        data: data,
        success: function (result) {
            window.location = location.origin
        },
        error: function (err) {
            window.location = location.origin
        }
    })
}

function handleFileUpload(event) {
    event.preventDefault();
    const fileInput = document.getElementById('fileInput');
    const file = fileInput.files[0];

    if (file) {
        const reader = new FileReader();

        reader.onload = function (e) {
            const fileBytes = new Uint8Array(e.target.result);
            const formData = new FormData();

            formData.append('CandidateId', document.getElementById('CandidateId').value);
            formData.append('DegreeType', document.getElementById('DegreeType').value);
            formData.append('file', new Blob([fileBytes]));

            $.ajax({
                type: "POST",
                method: 'POST',
                url: "Degree/UploadFile",
                contentType: false,
                processData: false,
                data: formData,
                success: function (res) {
                    window.location = location.origin
                },
                error: function (err) {
                    window.location = location.origin
                }
            })
        };

        reader.readAsArrayBuffer(file);
    }
}


function downloadFile(name, type, base64) {
    var base64String = base64;
    var fileName = name;
    var contentType = type;

    var byteCharacters = atob(base64String);
    var byteNumbers = new Array(byteCharacters.length);
    for (var i = 0; i < byteCharacters.length; i++) {
        byteNumbers[i] = byteCharacters.charCodeAt(i);
    }
    var byteArray = new Uint8Array(byteNumbers);

    var blob = new Blob([byteArray], { type: contentType });
    var url = URL.createObjectURL(blob);

    var link = document.createElement('a');
    link.href = url;
    link.download = fileName;
    link.click();

    URL.revokeObjectURL(url);
}