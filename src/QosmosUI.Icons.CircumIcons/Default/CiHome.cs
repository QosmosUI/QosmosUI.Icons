// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiHome : ComponentBase
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
		builder.AddAttribute(14, "id", "Home");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M19.37,10.22l-6.2-7.6a1.5,1.5,0,0,0-2.33-.01L4.63,10.22a2.5,2.5,0,0,0-.57,1.59v7.63a2.507,2.507,0,0,0,2.5,2.5H17.44a2.507,2.507,0,0,0,2.5-2.5V11.81A2.5,2.5,0,0,0,19.37,10.22ZM10,20.94v-5.5a1.5,1.5,0,0,1,1.5-1.5h1a1.5,1.5,0,0,1,1.5,1.5v5.5Zm8.94-1.5a1.511,1.511,0,0,1-1.5,1.5H15v-5.5a2.5,2.5,0,0,0-2.5-2.5h-1A2.5,2.5,0,0,0,9,15.44v5.5H6.56a1.511,1.511,0,0,1-1.5-1.5V11.81a1.474,1.474,0,0,1,.34-.95l6.22-7.61A.474.474,0,0,1,12,3.06a.479.479,0,0,1,.39.19l6.21,7.61a1.474,1.474,0,0,1,.34.95Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
