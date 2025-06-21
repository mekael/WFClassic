$(document).ready(function () {
    $('#playerTable').dataTable({
        "processing": "true",
        "serverSide": "false",
        "filter": "true",
        "ajax": {
            "url": "/getPlayerData/",
            "type": "GET",
            "datatype" :"json"
        },

        "columns": [
      
            { "data": "userName", "name": "User Name", "autoWidth": true },
            { "data": "joinedOnDate", "name": "Joined On", "autoWidth": true },
            { "data": "lastLoginDate", "name": "Last Login Date", "autoWidth": true },
            {
                "data":"isCurrentlyOnline",
                "render": function (data, row) { return data ? "Online":"Offline"; }
            },
            {
                "data": "id",
                "render": function (data, type, row) { return `<a href='/player/${data}' class='btn btn-danger'  >View</a>`; }
            }
        ]


    });
});
