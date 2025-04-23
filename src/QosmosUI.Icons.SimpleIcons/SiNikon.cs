// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiNikon : ComponentBase
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
		builder.AddAttribute(15, "d", "M8.267 8.681c-.69 0-1.054.463-1.054.873 0 .144.032.653.949.653.762 0 1.057-.488 1.057-.854 0-.244-.2-.672-.952-.672zm-6.87.215L0 15.146h1.72c.194-1 .455-2.056.711-3.138l1.206 3.136H5.27L6.681 8.9H5l-.715 3.176-1.18-3.18Zm8.587.004L8.6 15.144h1.663l.558-2.375.703 2.375h1.705l-.707-2.508 1.715-2.08h-1.91l-1.38 1.664.743-3.32zm6.608 1.465c-2.582 0-2.962 2.01-3.034 2.379-.19.93.02 2.137 1.235 2.457.8.21 2.051.187 2.855-.47.736-.6 1.1-1.619 1.088-2.575-.012-.92-.79-1.791-2.144-1.791zm6.193.072c-.573.038-1.156.35-1.486.807.044-.188.088-.404.14-.658h-1.7l-.999 4.558h1.695l.563-2.586c.104-.476.488-.68.826-.591.146.04.35.15.281.548l-.574 2.63h1.674l.767-3.51a.96.96 0 0 0-.627-1.14 1.594 1.594 0 0 0-.56-.058zm-15.66.121-1.02 4.586h1.676l1.022-4.586zm9.23 1.104c.372-.002.472.218.44.426-.09.545-.245 1.081-.362 1.539-.082.254-.321.4-.601.4-.286 0-.458-.178-.432-.406.04-.384.286-1.357.356-1.549.12-.334.451-.408.6-.41z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
