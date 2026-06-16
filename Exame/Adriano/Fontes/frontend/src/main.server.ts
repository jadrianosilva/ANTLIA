import { bootstrapApplication } from '@angular/platform-browser';
import { AppComponent } from './app/app.component';
import { provideRouter } from '@angular/router';
import { routes } from './app/app.routes';

bootstrapApplication(AppComponent, {
  providers: [provideRouter(routes)]
});

// O Angular Universal espera um "default export"
export default () => bootstrapApplication(AppComponent, {
  providers: [provideRouter(routes)]
});
