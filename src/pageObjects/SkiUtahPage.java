import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.PageFactory;


import java.util.List;

/**
 * Created on 9/19/2016.
 */
public class SkiUtahPage {

    public SkiUtahPage(WebDriver driver) {

        PageFactory.initElements(driver, this);
    }

    public List<String> dictionary;

public SkiUtahPage Crawl()
{
    //TODO Crawl through the website
    //TODO Get all of the words
    //TODO Add them to dictionary
    //TODO Return the page
    return this;
}

public void SaveDictionary()
{
    //TODO Save Dictionary to a file
}


}
