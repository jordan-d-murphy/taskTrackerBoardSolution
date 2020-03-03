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


                        

                        //              WORKING
                        //var card = $("#" + ui.draggable.attr("id"));
                        //card.load(" #" + ui.draggable.attr("id") + " > *");
                        //


                        //                ALSO WORKING           and possibly better...
                        var column = $("#" + result.newTaskStatus);
                        var card = $("#" + ui.draggable.attr("id"));
                        card.remove(); //  .detach()  is an alternative....
                        column.load(" #" + result.newTaskStatus + " > *");
                        //



                        //$(".droppable").droppable();
                        $('.draggable').droppable('enable');


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