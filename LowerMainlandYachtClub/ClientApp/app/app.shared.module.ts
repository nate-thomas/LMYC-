import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { RulesAndRegulationsComponent } from './components/rulesandregulations/rulesandregulations.component';
import { MyAccountComponent } from './components/myaccount/myaccount.component';
import { FleetComponent } from './components/about/fleet/fleet.component';
import { HistoryComponent } from './components/about/history/history.component';
import { AboutComponent } from './components/about/about.component';
import { BookingComponent } from './components/booking/booking.component';
import { EventsComponent } from './components/events/events.component';
import { FooterComponent } from './components/footer/footer.component';
import { MembershipComponent } from './components/membership/membership.component';
import { ReservationsComponent } from './components/myaccount/reservations/reservations.component';
import { FaqComponent } from './components/faq/faq.component';
import { LoginComponent } from './components/login/login.component';
import { Modal_NewMemberComponent } from "./components/membership/modal_newmember/modal_newmember.component";
import { Modal_VolunteerComponent } from "./components/myaccount/modal_volunteer/modal_volunteer.component";

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        RulesAndRegulationsComponent,
        MyAccountComponent,
        Modal_VolunteerComponent,
        ReservationsComponent,
        MembershipComponent,
        Modal_NewMemberComponent,
        FooterComponent,
        EventsComponent,
        BookingComponent,
        AboutComponent,
        FaqComponent,
        FleetComponent,
        HistoryComponent,
        LoginComponent,
        HomeComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'my-account', component: MyAccountComponent },
            { path: 'reservations', component: ReservationsComponent },
            { path: 'membership', component: MembershipComponent },
            { path: 'events', component: EventsComponent },
            { path: 'booking', component: BookingComponent },
            { path: 'about', component: AboutComponent },
            { path: 'history', component: HistoryComponent },
            { path: 'fleet', component: FleetComponent },
            { path: 'faq', component: FaqComponent },
            { path: 'home', component: HomeComponent },
            { path: 'login', component: LoginComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ]
})
export class AppModuleShared {
}
