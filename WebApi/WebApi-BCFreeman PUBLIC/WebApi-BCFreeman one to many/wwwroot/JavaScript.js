const URL = "api/products";
$(document).ready(function () {
    getData();
});
//
function getData() {
    $.ajax({
        type: "GET",
        url: URL,
        cache: false,
        success: function (data) {
            const getTodoItems = $("#Items");
            $(getTodoItems).empty();
            $.each(data, function (key, item) {
                const record = $("<tr></tr>")
                  
                    .append($("<td></td>").text(item.category.description))
                    .append($("<td></td>")
                        .append($("<button>Delete</button>")
                            .on("click", function ()
                                    {
                                        DELETE(item.id);
                                    }
                            )
                        )
                    );
                record.appendTo(getTodoItems);
            });
        }
    });
}
//
function DELETE(id) {
    $.ajax({
        url: URL + "/" + id,
        type: "DELETE",
        success: function (result) {
            getData();//odswiezenie
        }
    });
}


