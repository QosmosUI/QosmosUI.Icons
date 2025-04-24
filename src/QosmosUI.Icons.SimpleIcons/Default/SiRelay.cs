// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiRelay : ComponentBase
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
		builder.AddAttribute(15, "d", "M2.26428 4.93674C1.01354 4.93674 0 5.95018 0 7.20093c0 1.25074 1.01363 2.26428 2.26437 2.26428 1.05365 0 1.9393-.71975 2.1919-1.69462h10.3387c.98764 0 1.79128.80368 1.79128 1.79146 0 .98779-.80359 1.79156-1.79128 1.79156h-5.7309c-1.67246 0-3.03319 1.36067-3.03319 3.03318 0 1.67252 1.36063 3.03301 3.0332 3.03301h10.49429c.26987.9487 1.14197 1.64346 2.17735 1.64346 1.25074 0 2.26428-1.01344 2.26428-2.26419 0-1.25074-1.01354-2.26428-2.26428-2.26428-1.0353 0-1.9074.69469-2.17735 1.64328H9.06397c-.98777 0-1.79145-.80359-1.79145-1.79128 0-.98797.80358-1.79164 1.79146-1.79164h5.7309c1.67251 0 3.033-1.36063 3.033-3.0331 0-1.67246-1.36044-3.03319-3.033-3.03319H4.42718c-.2863-.92243-1.1464-1.59212-2.1629-1.59212Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
