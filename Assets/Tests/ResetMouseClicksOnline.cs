using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class ResetMouseClicksOnline {

    [Test]
    public void ResetMouseClicksOnlineSimplePasses() {

        int Taps = 8;
        int MaxTaps = 7;

        var engine = new ResetMouseClickOnline();

        var result = engine.TapDelJugador(Taps, MaxTaps);

        Assert.IsTrue(result);
    }
}
