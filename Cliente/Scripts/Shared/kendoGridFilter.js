function filterMenuInit(e) {
    var exclude = $('#filter-exclude').attr('filter-exclude').split(',');
    if (exclude.indexOf(e.field) !== -1) {
        var firstValueDropDown = e.container.find("select:eq(0)").data("kendoDropDownList");

        setTimeout(function () {
            firstValueDropDown.wrapper.hide();
        });
    }
}