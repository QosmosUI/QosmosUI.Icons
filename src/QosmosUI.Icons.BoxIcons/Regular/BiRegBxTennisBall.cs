// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Regular;

public class BiRegBxTennisBall : ComponentBase
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
		builder.AddAttribute(14, "d", "M4.929 19.081c1.895 1.895 4.405 2.938 7.071 2.938s5.177-1.043 7.071-2.938c3.899-3.899 3.899-10.243 0-14.143C17.177 3.044 14.665 2 12 2S6.823 3.044 4.929 4.938c-3.899 3.899-3.899 10.244 0 14.143zm12.728-1.414a7.969 7.969 0 0 1-3.813 2.129c-.009-1.602.586-3.146 1.691-4.251 1.163-1.163 2.732-1.828 4.277-1.851a7.945 7.945 0 0 1-2.155 3.973zm2.325-5.965c-2.124-.021-4.284.853-5.861 2.429-1.532 1.532-2.327 3.68-2.263 5.881a7.946 7.946 0 0 1-5.516-2.345 7.97 7.97 0 0 1-2.332-5.512c.077.002.154.014.231.014 2.115 0 4.16-.804 5.637-2.28 1.58-1.58 2.457-3.739 2.43-5.873a7.948 7.948 0 0 1 5.349 2.337 7.96 7.96 0 0 1 2.325 5.349zM6.343 6.353a7.968 7.968 0 0 1 3.973-2.169c-.018 1.555-.685 3.124-1.851 4.291-1.104 1.103-2.642 1.696-4.238 1.691a7.929 7.929 0 0 1 2.116-3.813z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
