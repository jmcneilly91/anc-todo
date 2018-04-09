$(document).ready(function () {
    // Send new item to the server on click
    $('#add-item-button').on('click', addItem);
});

function addItem() {
    $('#add-item-button').hide();
    var newTitle = $('#add-item-title').val();
    var newDueAt = $('#add-item-dueat').val();

    $.post('/ToDo/AddItem', { title: newTitle, dueAt: newDueAt }, function () {
        window.location = '/ToDo';
    }).fail(function (data) {
        if (data && data.responseJSON) {
            var firstError = data.responseJSON[Object.keys(data.responseJSON)[0]];
            $('#add-item-error').text(firstError);
            $('#add-item-error').show();
        }
    });
}