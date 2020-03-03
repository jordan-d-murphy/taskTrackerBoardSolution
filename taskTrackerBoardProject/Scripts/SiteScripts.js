$(document).ready(function () {
    console.log("Loaded site scripts for drag and drop!");
    $(function () {
        $(".draggable").draggable({
            zIndex: 100
        });
        $(".droppable").droppable({
            drop: function (event, ui) {
                $.ajax({
                    type: "POST",
                    url: "/Tasks/UpdateStatusAjax",
                    contentType: "application/json; charset=utf-8",
                    data: "{'taskID':'" + ui.draggable.attr("id") + "', 'newStatus':'" + $(this).attr("id") + "'}",
                    dataType: "json",
                    success: function (result) {
                        console.log('Success from ajax call! data result -> ');
                        console.log(result);


                        var card = $("#" + ui.draggable.attr("id"));
                        card.fadeOut(100).fadeIn(100).fadeOut(100).fadeIn(100);
                        card.css("background-color", "red");

                        //var statusLabel = container.find("b.status-label");
                        //statusLabel = result.newStatus;
                        //var content = container.innerHTML;
                        //container.innerHTML = content; 
                        //console.log("REFRESHED????");

                    },
                    error: function (xhr, status, error) {
                        alert('No success from ajax call. xhr: '
                            + xhr.responseText + "\n status: " + status + "\n error: " + error);
                    }
                });

            }
        });
    });
});