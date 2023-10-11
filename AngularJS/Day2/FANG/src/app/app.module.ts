import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { FooterComponent } from './components/footerCOM/footer.component';
import { HeaderComponent } from './components/headerCom/header.component';
import { MainComponent } from './components/mainCom/main.component';
import { MainCardComponent } from './components/mainCardCom/main-card.component';
import { FormsModule } from '@angular/forms';
import { SavingComponent } from './components/saving/saving.component';
import { ProductsComponent } from './components/products/products.component';
import { ComponentsBindingComponent } from './components/components-binding/components-binding.component';
import { NavBarComponent } from './components/nav-bar/nav-bar.component';

@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    HeaderComponent,
    MainComponent,
    MainCardComponent,
    SavingComponent,
    ProductsComponent,
    ComponentsBindingComponent,
    NavBarComponent
    ],
  imports: [ FormsModule,
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
