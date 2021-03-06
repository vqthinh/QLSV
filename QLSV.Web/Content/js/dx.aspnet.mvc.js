﻿(function($, DX) {

    var ui = DX.ui;

    ui.setTemplateEngine("underscore");

    $.extend(DX, {
        AspNet: {
            renderComponent: function(name, options, id) {
                id = id || ("dx-" + new DX.data.Guid());
                var templateRendered = ui.templateRendered;

                var render = function(_, container) {
                    $("#" + id, container)[name](options);
                    templateRendered.remove(render);
                };

                templateRendered.add(render);

                return "<div id=\"" + id + "\"></div>";
            }
        }
    });

})(jQuery, DevExpress);