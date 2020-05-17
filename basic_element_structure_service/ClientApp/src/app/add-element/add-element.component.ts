import { Component, OnInit } from '@angular/core';
import { Element } from "../models/Element"
import {Router,ActivatedRoute} from "@angular/router"
import {RequestServices} from "../services/requestServices"
import { getBaseUrl } from '../../main';
@Component({
  selector: 'app-add-element',
  templateUrl: './add-element.component.html',
  styleUrls: ['./add-element.component.css']
})
export class AddElementComponent implements OnInit {
  constructor(private _reqService: RequestServices,
    private _routerService:Router
  ) {
    this.newElement = new Element();
  }
  newElement: Element;
  ngOnInit() {
  }
  addNewElement() {
    this.newElement;
    this._reqService.createElement(this.newElement).subscribe(result =>
    {
      if (result)
      {
        this._routerService.navigate(["/element-data"]);
      }

    });
  }
}
