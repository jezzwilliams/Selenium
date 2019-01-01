﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestFramework
{
    public class TestCasesPage
    {
        public TestCasesPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //Find the login hyperlink
        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.clearfix.post-74.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-cases > div.mh-loop-content.clearfix > header > h3 > a")]

        public IWebElement UsernameCase { get; set; }
    }

}
