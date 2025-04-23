// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiHtop : ComponentBase
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
		builder.AddAttribute(15, "d", "M6.928 16.738v7.233h1.414v-7.233H6.928Zm10.912 0v7.233h1.414v-7.233H17.84Zm2.179 0v7.233h1.414v-7.233h-1.414Zm-4.366 0v7.233h1.414v-7.233h-1.414Zm-13.089 0v7.233h1.415v-7.233H2.564Zm2.183 0v7.233h1.414v-7.233H4.747ZM24 16.771l-.02 7.178-2.16-.008v-1.257h.827v-4.745h-.814V16.76l2.167.011Zm-24-.009.02 7.178 2.16-.008v-1.257h-.827v-4.744h.814v-1.18L0 16.762Zm6.928-8.356v7.233h1.414V8.406H6.928Zm2.182 0v7.233h1.414V8.406H9.11Zm2.181 0v7.233h1.414V8.406h-1.414Zm4.362 0v7.233h1.414V8.406h-1.414Zm2.187 0v7.233h1.414V8.406H17.84Zm2.179 0v7.233h1.414V8.406h-1.414Zm-17.455 0v7.233h1.415V8.406H2.564Zm2.183 0v7.233h1.414V8.406H4.747Zm8.726 0v7.233h1.415V8.406h-1.415ZM24 8.433l-.02 7.178-2.16-.008v-1.257h.827V9.601h-.814V8.422L24 8.433ZM0 8.43l.02 7.178 2.16-.008v-1.257h-.827V9.599h.814v-1.18L0 8.43ZM6.928.029v7.233h1.414V.029H6.928Zm8.725 0v7.233h1.414V.029h-1.414Zm4.366 0v7.233h1.414V.029h-1.414Zm-2.179 0v7.233h1.414V.029H17.84Zm-15.276 0v7.233h1.415V.029H2.564Zm2.183 0v7.233h1.414V.029H4.747ZM24 .055l-.02 7.178-2.16-.009V5.967h.827V1.223h-.814V.044L24 .055ZM0 .052.02 7.23l2.16-.008V5.965h-.827V1.221h.814V.041L0 .052Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
