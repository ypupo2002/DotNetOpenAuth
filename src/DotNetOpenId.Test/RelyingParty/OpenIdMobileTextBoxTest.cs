﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DotNetOpenId.Test.RelyingParty {
	[TestFixture]
	public class OpenIdMobileTextBoxTest {
		[Test]
		public void TextBoxAppears() {
			string html = TestSupport.Host.ProcessRequest(TestSupport.MobileConsumerPage);
			Assert.IsTrue(html.Contains("<input "));
		}
	}
}
