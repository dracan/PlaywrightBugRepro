Simple repro-case to show Playwright bug when using `LaunchPersistentContextAsync`.

You'll need to change the path in `Program.cs` to the profile path mentioned here: [chrome://version](chrome://version), without the final segment. Docs saying this are [here](https://playwright.dev/dotnet/docs/api/class-browsertype#browser-type-launch-persistent-context).


```
Unhandled exception. Microsoft.Playwright.PlaywrightException: Browser closed.
==================== Browser output: ====================
<launching> C:\Users\Dan\AppData\Local\ms-playwright\chromium-1028\chrome-win\chrome.exe --disable-field-trial-config --disable-background-networking --enable-features=NetworkService,NetworkServiceInProcess --disable-background-timer-throttling --disable-backgrounding-occluded-windows --disable-back-forward-cache --disable-breakpad --disable-client-side-phishing-detection --disable-component-extensions-with-background-pages --disable-default-apps --disable-dev-shm-usage --disable-extensions --disable-features=ImprovedCookieControls,LazyFrameLoading,GlobalMediaControls,DestroyProfileOnBrowserClose,MediaRouter,DialMediaRouteProvider,AcceptCHFrame,AutoExpandDetailsElement,CertificateTransparencyComponentUpdater,AvoidUnnecessaryBeforeUnloadCheckSync,Translate --allow-pre-commit-input --disable-hang-monitor --disable-ipc-flooding-protection --disable-popup-blocking --disable-prompt-on-repost --disable-renderer-backgrounding --disable-sync --force-color-profile=srgb --metrics-recording-only --no-first-run --enable-automation --password-store=basic --use-mock-keychain --no-service-autorun --export-tagged-pdf --no-sandbox --user-data-dir=C:\Users\Dan\AppData\Local\Google\Chrome\User Data --remote-debugging-pipe about:blank
<launched> pid=17128
[pid=17128][out] Opening in existing browser session.
=========================== logs ===========================
<launching> C:\Users\Dan\AppData\Local\ms-playwright\chromium-1028\chrome-win\chrome.exe --disable-field-trial-config --disable-background-networking --enable-features=NetworkService,NetworkServiceInProcess --disable-background-timer-throttling --disable-backgrounding-occluded-windows --disable-back-forward-cache --disable-breakpad --disable-client-side-phishing-detection --disable-component-extensions-with-background-pages --disable-default-apps --disable-dev-shm-usage --disable-extensions --disable-features=ImprovedCookieControls,LazyFrameLoading,GlobalMediaControls,DestroyProfileOnBrowserClose,MediaRouter,DialMediaRouteProvider,AcceptCHFrame,AutoExpandDetailsElement,CertificateTransparencyComponentUpdater,AvoidUnnecessaryBeforeUnloadCheckSync,Translate --allow-pre-commit-input --disable-hang-monitor --disable-ipc-flooding-protection --disable-popup-blocking --disable-prompt-on-repost --disable-renderer-backgrounding --disable-sync --force-color-profile=srgb --metrics-recording-only --no-first-run --enable-automation --password-store=basic --use-mock-keychain --no-service-autorun --export-tagged-pdf --no-sandbox --user-data-dir=C:\Users\Dan\AppData\Local\Google\Chrome\User Data --remote-debugging-pipe about:blank
<launched> pid=17128
[pid=17128][out] Opening in existing browser session.
============================================================
   at Microsoft.Playwright.Transport.Connection.InnerSendMessageToServerAsync[T](String guid, String method, Object args) in /_/src/Playwright/Transport/Connection.cs:line 163
   at Microsoft.Playwright.Transport.Connection.WrapApiCallAsync[T](Func`1 action, Boolean isInternal)
   at Microsoft.Playwright.Core.BrowserType.LaunchPersistentContextAsync(String userDataDir, BrowserTypeLaunchPersistentContextOptions options) in /_/src/Playwright/Core/BrowserType.cs:line 87
   at Program.<Main>$(String[] args) in C:\Dump\PlaywrightBugRepro\Program.cs:line 5
   at Program.<Main>(String[] args)
```