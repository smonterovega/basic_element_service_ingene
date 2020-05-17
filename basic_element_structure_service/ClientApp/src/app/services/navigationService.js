"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
core_1.Injectable();
var NavigationService = /** @class */ (function () {
    function NavigationService(_router) {
        this._router = _router;
    }
    NavigationService.prototype.goToElementDataComponent = function () {
        this._router.navigate(["/element-data"]);
    };
    return NavigationService;
}());
exports.NavigationService = NavigationService;
//# sourceMappingURL=navigationService.js.map