$(document).ready(function () {
    var table = $("#products").DataTable({
        select: true,
        ajax: {
            url: "/api/products",
            dataSrc: ""
        },
        columns: [
            { data: "id" },
            { data: "name" },
            { data: "description" },
            {
                data: "dateAdded",
                render: function (data, type, row) {
                    var dateSplit = data.split("T");
                    var dateSplit2 = dateSplit[0].split("-");
                    return dateSplit2[2] + "." + dateSplit2[1] + "." + dateSplit2[0];
                }
            }
        ]
    });
});