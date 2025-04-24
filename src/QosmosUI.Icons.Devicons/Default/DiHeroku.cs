// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons.Default;

public class DiHeroku : ComponentBase
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
		builder.AddAttribute(14, "d", "M7.73 9.828c0 3.552 0.097 6.459 0.226 6.459 0.097 0 1.776-0.517 3.746-1.13 2.68-0.904 3.972-1.13 5.361-1.066l1.808 0.097 0.097 7.492 0.065 7.524h3.875v-7.88c0-7.653-0.032-7.879-0.743-8.945-1.292-1.938-4.618-2.358-8.752-1.13l-1.486 0.452v-8.332h-4.198v6.459zM18.872 5.727c-0.711 1.26-1.324 2.422-1.389 2.551-0.065 0.161 0.807 0.258 1.938 0.258h2.034l1.162-1.873c2.228-3.488 2.261-3.294-0.258-3.294h-2.196l-1.292 2.357zM7.73 25.167c0 2.034 0.129 3.714 0.258 3.714s1.066-0.839 2.099-1.873l1.841-1.873-1.873-1.841c-1.033-1.001-1.97-1.841-2.099-1.841s-0.226 1.679-0.226 3.714z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
