// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiStoneThrone : ComponentBase
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
		builder.AddAttribute(14, "d", "M255.563 21.125L162.5 53.188v216.75H180.063v35.093H333V269.94h17.564l-.002-216.594-95-32.22zm-143.22 9.156v239.657h31.47V30.28h-31.47zm256.907 0v239.657h31.47V30.28h-31.47zM203.687 59.157l30.938 33.875 22.188-33.28 22.218 33.28 28.595-31.53-11.688 63.656h-80l-12.25-66zM77.844 288.626v34.28h83.53v-34.28h-83.53zm273.844 0v34.28h83.53v-34.28h-83.53zm-171.625 35.093v17.874h-17.408v15.22l187.75-.002v-15.218H333V323.72H180.062zM95.25 341.593v150.47l48.72-.002V341.595H95.25zm273.844 0v150.47l48.72-.002-.002-150.468h-48.718zM162.656 375.5v97.156h187.75V375.5h-187.75z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
