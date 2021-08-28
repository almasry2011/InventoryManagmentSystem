import { DOCUMENT } from '@angular/common';
import { Component, Inject } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'InventoryManagementUI';

  isLoggedIn = true;

/**
 *
 */
constructor(private translateService: TranslateService, @Inject(DOCUMENT) private document: Document) {
  this.translateService.setDefaultLang('en');
  this.translateService.use('en').subscribe(
    next => { console.log('Initialized translations') }
  );
}

changeLangage(lang: string) {
  let htmlTag = this.document.getElementsByTagName(
    "html"
  )[0] as HTMLHtmlElement;
 // htmlTag.dir = lang === "ar" ? "rtl" : "ltr";
  this.translateService.setDefaultLang(lang);
  this.translateService.use(lang);
  this.changeCssFile(lang);
}



changeCssFile(lang: string) {
  debugger;
  let headTag = this.document.getElementsByTagName(
    "head"
  )[0] as HTMLHeadElement;
  let existingLink = this.document.getElementById(
    "langCss"
  ) as HTMLLinkElement;



  let bundleName = lang === "ar" ? "arabicStyle.css" : "englishStyle.css";

  if (existingLink) {
    existingLink.href = bundleName;
  } else {
    let newLink = this.document.createElement("link");
    newLink.rel = "stylesheet";
    newLink.type = "text/css";
    newLink.id = "langCss";
    newLink.href = bundleName;
    headTag.appendChild(newLink);
  }


  console.log("**********************existingLink******************")

console.log(existingLink)

}










}

