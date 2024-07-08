
function getInitials(fullName) {
    const names = fullName.split(' ');
    const initials = names.map(name => name.charAt(0).toUpperCase()).join('');
    return initials;
}

function updateMississaugaCount(data) {
    const count = data.filter(emp => emp.city === 'Mississauga').length;
    $('#mississauga-count').text(`${count} Employees from Mississauga`);
}

function initGrid(gridId, dataUrl) {
    $(gridId).kendoGrid({
        dataSource: {
            transport: {
                read: {
                    url: dataUrl,
                    type: 'GET',
                    dataType: 'json'
                }
            },
            schema: {
                model: {
                    fields: {
                        fullName: { type: 'string' },
                        employeeID: { type: 'string' },
                        sin: { type: 'number' },
                        phoneNumber: { type: 'number' },
                        city: { type: 'string' },
                        salary: { type: 'number' },
                        country: { type: 'string' }
                    }
                }
            },
            pageSize: 5
        },
        pageable: true,
        dataBound: function (e) {
            const grid = e.sender;
            const items = grid.items();
            const data = grid.dataSource.data();

            updateMississaugaCount(data);

            items.each(function () {
                const dataItem = grid.dataItem(this);
                const avatarElem = $(this).find('.avatar');
                const initials = getInitials(dataItem.fullName);
                avatarElem.kendoAvatar({
                    type: 'text',
                    text: initials
                });
            });
        },
        columns: [
            {
                title: 'Full Name',
                template: `<div class="employee-info">
                                <div class="avatar"></div>
                                <div class="employee-details">
                                    <div class="employee-name">#: fullName #</div>
                                    <div class="employee-id">#: employeeID #</div>
                                </div>
                            </div>`,
            },
            {
                field: 'sin',
                title: 'SIN',
                template: function (dataItem) {
                    const sin = dataItem.sin.toString();
                    return sin.substr(0, 3) + "-" + sin.substr(3, 3) + "-" + sin.substr(6, 3);
                }
            },
            {
                field: 'phoneNumber',
                title: 'Phone Number',
                template: function (dataItem) {
                    const phone = dataItem.phoneNumber.toString();
                    return "(" + phone.substr(0, 3) + ") " + phone.substr(3, 3) + "-" + phone.substr(6, 4);
                }
            },
            {
                field: 'city',
                title: 'City',
                template: function (dataItem) {
                    return dataItem.city === 'Mississauga' ?
                        '<h6><span class="badge bg-primary" style=>' + dataItem.city + '</span></h6>' : dataItem.city;
                }
            },
            { field: 'salary', title: 'Salary', format: '{0:c2}' },
            {
                field: 'country',
                title: 'Country',
                template: function (dataItem) {
                    return dataItem.country === 'Canada' ?
                        '<span style="color: red;">' + dataItem.country + '</span>' : dataItem.country;
                }
            }
        ]
    });
}

