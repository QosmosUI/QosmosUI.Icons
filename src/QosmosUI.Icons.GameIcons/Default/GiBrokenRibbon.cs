// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBrokenRibbon : ComponentBase
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
		builder.AddAttribute(14, "d", "M129.867 26.06l-1.05 59.12c87.818 31.78 175 31.654 262.9 1.535l-1.07-60.106c-87.14 22.31-174.228 18.73-260.78-.55zm-1.4 78.813l-3.317 186.662 72.694-65.21 62.41 207.1 62.41-207.1 72.69 65.21-3.29-185.213c-5.706 1.87-11.415 3.633-17.127 5.262l-50.962 70.947-45.288-55.13c-11.9.51-23.805.482-35.708-.09l-45.363 55.22-51.494-71.684.268-.192c-5.976-1.782-11.95-3.718-17.923-5.78zm45.77 13.066l24.374 33.93 21.617-26.313c-15.337-1.63-30.67-4.166-45.99-7.618zm172.644.662c-15.104 3.245-30.222 5.635-45.347 7.158l21.45 26.11 23.898-33.268zM183.343 313.717L85.838 439.95l84.443 53.974 13.062-180.207zm146.088 0l13.06 180.207 84.444-53.975-97.504-126.233z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
