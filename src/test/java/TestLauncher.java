import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.testng.Assert;
import org.testng.annotations.BeforeSuite;
import org.testng.annotations.Test;


/**
 * Created on 9/19/2016.
 */
public class TestLauncher {

    public WebDriver driver;
    SkiUtahPage page;
@BeforeSuite
public void SetUp()
{
    driver = new ChromeDriver();
    driver.get("http://www.skiutah.com");
    page = new SkiUtahPage(driver);

}
@Test
public void VerifyDictionaryExists()
{
    page.Crawl();
    Assert.assertFalse(page.dictionary.isEmpty());
}


}
