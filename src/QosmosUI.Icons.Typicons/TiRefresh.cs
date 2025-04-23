// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons;

public class TiRefresh : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M12.872 13.191h5.128v-5.127c-.008-1.135-.671-1.408-1.473-.605l-1.154 1.158c-1.015-.795-2.257-1.23-3.566-1.23-1.55 0-3.009.604-4.104 1.701-1.099 1.092-1.703 2.553-1.703 4.103 0 1.553.604 3.012 1.701 4.107 1.097 1.097 2.555 1.702 4.106 1.702 1.55 0 3.009-.605 4.106-1.703.296-.297.558-.621.78-.965.347-.541.19-1.26-.35-1.605-.539-.346-1.258-.189-1.604.35-.133.207-.292.4-.468.58-.659.658-1.534 1.02-2.464 1.02-.93 0-1.805-.361-2.464-1.02-.657-.658-1.02-1.533-1.02-2.465 0-.93.362-1.805 1.02-2.461.659-.658 1.534-1.021 2.464-1.021.688 0 1.346.201 1.909.572l-1.448 1.451c-.803.802-.53 1.458.604 1.458z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
