$(document).ready(function () {
    console.log("Loaded site scripts for drag and drop!");
    $(function () {
        $(".draggable").draggable({
            zIndex: 100
        });
        $(".droppable").droppable({
            drop: function (event, ui) {
                console.log("dragged element " + ui.draggable.attr("id") +
                    " onto target droppable element " + $(this).attr("id") +
                    " -> ready to pass to controller and reload page");

                $.post('/Tasks/Edit',
                    {
                        ID: ui.draggable.attr("id"),
                        CurrentStatus: $(this).attr("id")
                    },
                    function (data) {

                    console.log("Here is the return value -> " + data);

                });

            }
        });
    });
});