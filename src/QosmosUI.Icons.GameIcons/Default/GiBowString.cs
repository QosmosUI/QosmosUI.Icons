// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBowString : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M114.4 35.99l36.8 85.91c4 2.4 7.9 4.9 11.8 7.5V66.55c-16-11.07-32.2-21.32-48.6-30.56zM181 50.56V160c0 .2.7 2.4 3.4 4.9 2.7 2.5 6.9 5.1 10.9 6.7 3.2 1.3 5.9 1.7 7.7 1.8V64c0-.25-.7-2.39-3.4-4.92s-6.9-5.11-10.9-6.72c-3.2-1.26-5.9-1.69-7.7-1.8zm40 60.54v63.2c48.3 43.4 88.2 95.2 118.7 145 22.3 36.5 39.5 71.9 51.2 102.5 9.9 25.8 16 47.9 17.6 65.2h93.1c-3.4-15.2-13.9-41.6-31-72.9-21.2-38.8-52-85.9-89.7-134.6C336 221.7 281.2 161.7 221 111.1zm-38 74.7V486h18V191.5c-4.2-.3-8.3-1.5-12.3-3.1-1.9-.8-3.8-1.7-5.7-2.6z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
