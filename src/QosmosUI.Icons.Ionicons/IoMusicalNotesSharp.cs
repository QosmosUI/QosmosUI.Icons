// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoMusicalNotesSharp : ComponentBase
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
		builder.AddAttribute(14, "d", "M429.46,32.07c-23.6,6.53-205.55,58.81-250.54,71.43a4,4,0,0,0-2.92,3.83v247a2,2,0,0,1-1.33,1.89l-27.85,9.55c-19,7.44-66.82,16.68-66.82,59.19,0,35.54,24.63,51.54,45.86,54.28a52.06,52.06,0,0,0,7.81.8c7.37,0,36.38-7.08,53.3-18.08C208,448.25,208,448,208,412V202c0-.9.62-.84,1.48-1.07l188-51.92a2,2,0,0,1,2.53,2V306.55a2,2,0,0,1-1.36,1.89c-8.9,3-19.23,6.5-26.48,9.12C341.39,328.68,304,335.65,304,376c0,38.51,28.26,54.58,46.3,55.83a87.37,87.37,0,0,0,21.33-1c9-1.38,24.09-5.9,38.14-14.86C432,401.79,432,401.51,432,360V34A2,2,0,0,0,429.46,32.07Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
