import { Component, OnInit } from '@angular/core';
import { Element } from "../models/Element"
import {RequestServices} from "../services/requestServices"
import {NavigationService} from "../services/navigationService"
import { getBaseUrl } from '../../main';
@Component({
  selector: 'app-add-element',
  templateUrl: './add-element.component.html',
  styleUrls: ['./add-element.component.css']
})
export class AddElementComponent implements OnInit {
  constructor(private _reqService: RequestServices,
    private _navService:NavigationService
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
        this._navService.goToElementDataComponent();
      }

    });
  }
}
