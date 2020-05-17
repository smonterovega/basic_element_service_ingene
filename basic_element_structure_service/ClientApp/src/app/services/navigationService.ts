import { Injectable } from "@angular/core";
import { Router, ActivatedRoute } from "@angular/router"
@Injectable()
export class NavigationService {
  constructor(
    private _router: Router
  ) {

  }
  goToElementDataComponent() {
    this._router.navigate(["/element-data"]);
  }
}
