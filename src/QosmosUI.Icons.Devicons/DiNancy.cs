// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons;

public class DiNancy : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "32";

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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M8.133 2.922c0.677 3.554 1.219 9.138 1.049 10.56-0.135 0.948-0.745 2.674-1.32 3.858-1.185 2.369-1.151 2.505 0.745 3.486 0.677 0.338 0.779 0.643 0.677 1.828-0.101 1.252 0 1.422 0.677 1.523s0.779 0.271 0.609 0.948c-0.203 0.711-0.068 0.88 0.778 1.185 0.779 0.271 1.015 0.609 1.185 1.659 0.271 1.658 1.422 2.538 2.945 2.234 0.542-0.101 2.031-0.812 3.283-1.523 1.252-0.744 2.911-1.455 3.689-1.59 1.388-0.203 1.388-0.203 1.929-2.369 1.015-3.96 0.575-5.788-0.711-3.148-0.88 1.726-3.249 3.689-4.468 3.689-0.304 0-0.101-0.271 0.474-0.643 4.502-2.809 5.178-9.037 1.455-13.098-1.489-1.591-2.166-1.794-0.981-0.271 1.117 1.421 1.828 4.265 1.557 6.261-0.237 1.76-1.286 3.351-2.674 4.096-0.541 0.304-0.44 0.068 0.406-0.88 0.914-1.049 1.083-1.523 1.083-2.944 0-2.877-1.862-5.991-7.074-11.812-2.132-2.369-1.591-0.338 0.778 3.046 1.794 2.505 1.726 2.64-0.271 0.575-1.625-1.692-3.892-4.502-5.551-6.871-0.406-0.575-0.406-0.575-0.271 0.203z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
