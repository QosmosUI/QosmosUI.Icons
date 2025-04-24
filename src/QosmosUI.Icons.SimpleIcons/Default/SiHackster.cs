// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiHackster : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M19.091 13.294c-.057.05-.247.09-.396.132l-4.778 1.306c-.15.041-.273-.052-.273-.208V13.29a.282.282 0 00-.283-.283H8.117a.282.282 0 01-.282-.282V11.29a.283.283 0 00-.283-.283H5.035c-.1 0-.18-.08-.18-.178 0-.058.025-.098.055-.126.056-.052.246-.093.397-.134l4.758-1.3c.15-.042.272.051.272.208v1.247c0 .156.128.283.284.283h5.24c.156 0 .282.126.282.283v1.42c0 .157.127.284.282.284h2.542a.18.18 0 01.18.179.158.158 0 01-.056.12m-2.948 2.288a.39.39 0 01-.272.356l-1.954.534c-.15.042-.273-.052-.273-.208v-.728c0-.157.127-.284.283-.284h1.933c.157 0 .283.127.283.284zm-5.81 1.586a.39.39 0 01-.272.357l-1.953.535c-.15.04-.273-.053-.273-.209v-3.758c0-.157.127-.284.283-.284h1.933c.156 0 .283.127.283.284zM7.836 8.46c0-.156.122-.316.273-.357l1.952-.534c.152-.042.274.052.274.208v.729a.283.283 0 01-.283.283H8.118a.283.283 0 01-.283-.283zm5.809-1.587c0-.157.122-.316.273-.358l1.954-.533c.15-.042.272.052.272.208v3.759a.283.283 0 01-.283.283h-1.933a.283.283 0 01-.283-.283zM12 0C5.384 0 0 5.384 0 12c0 6.617 5.384 12 12 12 6.618 0 12-5.383 12-12 0-6.616-5.382-12-12-12Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
