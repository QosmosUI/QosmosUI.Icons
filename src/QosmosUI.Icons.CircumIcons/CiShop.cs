// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiShop : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Shop");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M20.6,5.26a2.512,2.512,0,0,0-2.48-2.2H5.885a2.512,2.512,0,0,0-2.48,2.19l-.3,2.47a3.411,3.411,0,0,0,1.16,2.56v8.16a2.5,2.5,0,0,0,2.5,2.5h10.47a2.5,2.5,0,0,0,2.5-2.5V10.28A3.411,3.411,0,0,0,20.9,7.72Zm-6.59,14.68h-4V15.86a1.5,1.5,0,0,1,1.5-1.5h1a1.5,1.5,0,0,1,1.5,1.5Zm4.73-1.5a1.5,1.5,0,0,1-1.5,1.5h-2.23V15.86a2.5,2.5,0,0,0-2.5-2.5h-1a2.5,2.5,0,0,0-2.5,2.5v4.08H6.765a1.5,1.5,0,0,1-1.5-1.5V10.87a3.223,3.223,0,0,0,1.24.24,3.358,3.358,0,0,0,2.58-1.19.241.241,0,0,1,.34,0,3.358,3.358,0,0,0,2.58,1.19A3.393,3.393,0,0,0,14.6,9.92a.219.219,0,0,1,.16-.07.238.238,0,0,1,.17.07,3.358,3.358,0,0,0,2.58,1.19,3.173,3.173,0,0,0,1.23-.24Zm-1.23-8.33a2.386,2.386,0,0,1-1.82-.83,1.2,1.2,0,0,0-.92-.43h-.01a1.194,1.194,0,0,0-.92.42,2.476,2.476,0,0,1-3.65,0,1.24,1.24,0,0,0-1.86,0A2.405,2.405,0,0,1,4.1,7.78l.3-2.4a1.517,1.517,0,0,1,1.49-1.32h12.23a1.5,1.5,0,0,1,1.49,1.32l.29,2.36A2.392,2.392,0,0,1,17.505,10.11Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
