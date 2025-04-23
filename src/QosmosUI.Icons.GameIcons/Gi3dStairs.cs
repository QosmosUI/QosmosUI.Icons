// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class Gi3dStairs : ComponentBase
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
		builder.AddAttribute(14, "d", "M325.944 61.815l-98.26 24.566 147.158 66.891 98.263-24.566zM209.787 97.687v43.488l155.355 70.617v-43.489zM491 142.475l-108.159 27.04v62.929c-20.977 5.241-41.953 10.488-62.929 15.732v62.929c-20.977 5.241-41.953 10.488-62.929 15.732v62.93c-20.977 5.24-41.952 10.487-62.929 15.731v44.687L491 375.947zm-290.914 13.733l-35.332 8.834 147.16 66.891 35.334-8.834zm-53.228 20.14v43.488l155.355 70.617v-43.489zm-9.7 58.521l-35.333 8.834 147.16 66.891 35.334-8.834zm-53.23 20.14v43.488l155.357 70.617v-43.489zm-9.7 58.522l-35.331 8.834 147.159 66.89 35.334-8.834zM21 333.67v43.487l155.356 70.617v-43.488z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
