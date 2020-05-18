import { Component, OnInit } from '@angular/core';
import {RequestServices} from "../services/requestServices"
import {Element, charge} from "../models/Element"
@Component({
  selector: 'app-element-data',
  templateUrl: './element-data.component.html',
  styleUrls: ['./element-data.component.css']
})
export class ElementDataComponent implements OnInit {

  public allElements: Element[];
  chargeToString = charge;
  private showElementList: boolean = true;
  constructor(private _requestService: RequestServices) {
    this._requestService.getAllElements().subscribe(result => {
      this.allElements = result;
    }); 
  }

  onAddElementButtonClick() {

  }
  ngOnInit() {
  }

}
