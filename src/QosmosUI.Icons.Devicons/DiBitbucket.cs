// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons;

public class DiBitbucket : ComponentBase
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
		builder.AddAttribute(14, "d", "M16 3.737v0c-6.126 0-11.127 1.647-11.127 3.692 0 0.539 1.336 8.261 1.866 11.324 0.238 1.373 3.787 3.387 9.259 3.387l0.006-0.017v0.017c5.472 0 9.021-2.014 9.259-3.387 0.53-3.063 1.866-10.785 1.866-11.324-0-2.045-5.002-3.692-11.128-3.692zM16 19.659c-1.953 0-3.537-1.584-3.537-3.537s1.584-3.537 3.537-3.537c1.954 0 3.537 1.584 3.537 3.537s-1.584 3.537-3.537 3.537zM15.998 8.57c-3.936-0.006-7.125-0.69-7.124-1.528s3.193-1.511 7.129-1.505c3.936 0.006 7.125 0.69 7.124 1.528s-3.193 1.511-7.129 1.505zM23.998 21.23c-0.169 0-0.305 0.12-0.305 0.12s-2.74 2.17-7.693 2.17c-4.953-0-7.693-2.17-7.693-2.17s-0.136-0.12-0.305-0.12c-0.202 0-0.394 0.136-0.394 0.435 0 0.032 0.003 0.063 0.009 0.094 0.425 2.276 0.736 3.891 0.791 4.137 0.371 1.675 3.647 2.938 7.591 2.938v0h0.001c3.945-0 7.22-1.264 7.591-2.938 0.055-0.246 0.365-1.861 0.791-4.137 0.006-0.031 0.009-0.062 0.009-0.094 0-0.3-0.192-0.435-0.393-0.435zM18.030 16.15c0 1.064-0.863 1.927-1.927 1.927s-1.927-0.863-1.927-1.927c0-1.064 0.863-1.927 1.927-1.927s1.927 0.863 1.927 1.927z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
