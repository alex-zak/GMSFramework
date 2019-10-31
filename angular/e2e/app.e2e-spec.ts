import { GMSFrameworkTemplatePage } from './app.po';

describe('GMSFramework App', function() {
  let page: GMSFrameworkTemplatePage;

  beforeEach(() => {
    page = new GMSFrameworkTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
